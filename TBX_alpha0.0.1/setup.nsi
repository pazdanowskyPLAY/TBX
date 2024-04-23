Unicode false
ManifestSupportedOS all

!define AppVersion "Alpha 0.0.1"
Name "TBXSetup for ${AppVersion}"
OutFile "TBX ${AppVersion}.exe"
Icon "tbx-setup.ico"

InstallDir "$DESKTOP\BYRg Studio\TBX\${AppVersion}"
InstallDirRegKey HKLM "Software\BYRg Studio\TBX ${AppVersion}" "Install_Directory"

LoadLanguageFile "${NSISDIR}\Contrib\Language files\Polish.nlf"
RequestExecutionLevel admin
SetCompress auto
Setcompressor /FINAL bzip2
SetDatablockOptimize on
CRCCheck force
ShowInstDetails nevershow
ShowUninstDetails nevershow
InstProgressFlags smooth
AllowSkipFiles off
AutoCloseWindow false

###

LicenseData "README"
LicenseText "LICENCJA" "Zgadzam się"
LicenseForceSelection checkbox "Akceptuje przedstawione warunki"
SetDateSave on

BrandingText "Instalator stworzony dzięki NSIS!"
InstallButtonText "Zainstaluj..."
UninstallButtonText "Odinstaluj..."

###

VIAddVersionKey "CompanyName" "BYRg Studio"
VIAddVersionKey "FileDescription" "TBX Installer"
VIAddVersionKey "ProductName" "TBX"
VIAddVersionKey "Comments" "hotfix 3/22-04-2024"
VIAddVersionKey "LegalCopyright" "(CC) CopyCenter 2020-2024"
VIAddVersionKey "FileVersion" "0.2.1.1"
VIProductVersion "0.0.1.3"

###

Page license
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

###

Section "INSTALLER"
	File /a /r "README"
	File /a /r "CHANGELOG"
	File /a /r chapters
	File /a /r assets
	SetOutPath $INSTDIR

	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "DisplayName" '"TBX ${AppVersion} uninstaller"'
	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "UninstallString" '"uninst(${AppVersion}).exe"'
	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "ID_A" "0000-0000-0000-0000-000001"
	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "ID_B" "0000-0000-0000-0000-000002"
	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "ID_DEV" "9F9F-9F9F-9F9F-9F9F-181257"
	WriteUninstaller '"uninst(${AppVersion}).exe"'
SectionEnd

Section "un.INSTALLER"
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"
	DeleteRegKey HKLM "Software\BYRg Studio\TBX ${AppVersion}"
	Delete '$DESKTOP\BYRg Studio\TBX\${AppVersion}\*.*'
	RMDir "$DESKTOP\BYRg Studio\TBX\${AppVersion}"
SectionEnd

Function .onInit
	StrCpy $LANGUAGE "1045"
	System::Call 'kernel32::CreateMutex(p 0, i 0, t "myMutex") p .r1 ?e'
	Pop $R0
	StrCmp $R0 0 +3
   	MessageBox MB_OK|MB_ICONEXCLAMATION "Instalator jest już uruchomiony."
   	Abort

	MessageBox MB_YESNO|MB_ICONINFORMATION|MB_DEFBUTTON2 "UWAGA!$\nWersja TBX, którą chcesz zainstalować, jest jeszcze w stanie rozwoju Alpha. Oznacza to, że program może posiadać pewne błędy nawet zagrażające funkcjonalności komputera.$\nCzy chcesz kontynuować?"\
		IDYES installyes IDNO installno
	installno:
		Abort
	installyes:
FunctionEnd

Function un.onInit
	StrCpy $LANGUAGE "1045"
	System::Call 'kernel32::CreateMutex(p 0, i 0, t "myMutex") p .r1 ?e'
	Pop $R1
	StrCmp $R1 0 +3
   	MessageBox MB_OK|MB_ICONEXCLAMATION "Deinstalator jest już uruchomiony."
   	Abort

	MessageBox MB_YESNO|MB_ICONINFORMATION|MB_DEFBUTTON1 "Czy chcesz odinstalować TBX ${AppVersion}?"\
		IDYES uninstallyes IDNO uninstallno
	uninstallno:
		Abort
	uninstallyes:
FunctionEnd

###

Function .onInstFailed
	MessageBox MB_OK|MB_ICONSTOP "Wystąpił błąd"
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Dziękujemy serdecznie za skorzystanie z wersji ${AppVersion}. Czy chcesz zobaczyć plik README?" IDNO NoReadme
    	Exec 'notepad.exe $INSTDIR/README'
	NoReadme:
FunctionEnd

; ak vop sfermed pro spes maned, if om pobl to pobl, ne ei mnoka pfo an am lank
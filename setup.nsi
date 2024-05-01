; przed kompilacj� nale�y przenie�� plik LICENSE do folderu gry!
Unicode false
ManifestSupportedOS all

LoadLanguageFile "${NSISDIR}\Contrib\Language files\Polish.nlf"
!define AppVersion "Alpha 0.0.1.0"
Name "TBX ${AppVersion} Setup"
OutFile "TBX ${AppVersion}.exe"
Icon "gallery/tbx-setup.ico"

InstallDir "$DESKTOP\BYRg Studio\TBX\${AppVersion}"
InstallDirRegKey HKLM "Software\BYRg Studio\TBX ${AppVersion}" "Install_Directory"

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
LicenseText "LICENSE" "Zgadzam si�"
LicenseForceSelection checkbox "Akceptuje przedstawione warunki"
SetDateSave on

BrandingText "Instalator stworzony dzi�ki NSIS!"
InstallButtonText "Zainstaluj"
UninstallButtonText "Odinstaluj"

###

VIAddVersionKey "CompanyName" "BYRg Studio"
VIAddVersionKey "FileDescription" "TBX ${AppVersion} Setup"
VIAddVersionKey "ProductName" "TBX"
VIAddVersionKey "Comments" "hotfix 3/22-04-2024"
VIAddVersionKey "LegalCopyright" "(CC) CopyCenter 2020-2024"
VIAddVersionKey "FileVersion" "0.2.0.0"
VIProductVersion "0.0.1.0"

###

Page license
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

###

Section "INSTALLER"
	File /a /r "TBX_Alpha_0.0.1.0"
	SetOutPath $INSTDIR

	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "DisplayName" '"TBX ${AppVersion} Uninstaller"'
	WriteRegStr HKLM '"Software\Microsoft\Windows\CurrentVersion\Uninstall\TBX\${AppVersion}"' "UninstallString" '"uninst(${AppVersion}).exe"'
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
   	MessageBox MB_OK|MB_ICONEXCLAMATION "Instalator jest ju� uruchomiony."
   	Abort

	MessageBox MB_YESNO|MB_ICONINFORMATION|MB_DEFBUTTON2 "UWAGA!$\nWersja TBX, kt�r� chcesz zainstalowa�, jest jeszcze w stanie rozwoju Alpha. Oznacza to, �e program mo�e posiada� pewne b��dy nawet zagra�aj�ce funkcjonalno�ci komputera.$\nCzy chcesz kontynuowa�?"\
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
   	MessageBox MB_OK|MB_ICONEXCLAMATION "Deinstalator jest ju� uruchomiony."
   	Abort

	MessageBox MB_YESNO|MB_ICONINFORMATION|MB_DEFBUTTON1 "Czy chcesz odinstalowa� TBX ${AppVersion}?"\
		IDYES uninstallyes IDNO uninstallno
	uninstallno:
		Abort
	uninstallyes:
FunctionEnd

###

Function .onInstFailed
	MessageBox MB_OK|MB_ICONSTOP "Wyst�pi� nieoczekiwany b��d podczas instalacji."
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Dzi�kujemy serdecznie za skorzystanie z wersji ${AppVersion}. Czy chcesz zobaczy� plik LICENSE?" IDNO NoLicense
    	Exec 'notepad.exe $INSTDIR/LICENSE'
	NoLicense:
FunctionEnd

; ak vop sfermed pro spes maned, if om pobl to pobl, ne ei mnoka pfo an am lank
using System;
using System.Windows.Forms;
using System.Drawing;

// -.-.-- / .- .-. -.-. .... .. ...- . -....- .---- --... ----. ----. ...-- / ..... ..... ..--- .---- -....- ----. ..--- ----. .---- -....- -.... -.... --... .---- -....- ----. ----. ---.. .---- -....- ----- ----- ----- ----- -....- ----- ----- ----- ----- -....- ----- .---- ..--- ----- / .- -.-. ---... ... .---- --.- ..--- .-. - ----- ----- ...- ....- .--. --... ..-. ----. --. / -.-.-- /

public class Hform : Form
{
    // definiowanie zmiennych
    RichTextBox tekst = new RichTextBox();

    MenuStrip menu = new MenuStrip();

    static public void Main ()
    {
        Application.Run (new Hform ());
    }

    public Hform ()
    {
        // tytuł okna
        Text = "notepa[ð]-minimal";
        
        // naśrodku ekranu
        this.StartPosition = FormStartPosition.CenterScreen;

        // wymiary okna
        this.Size = new System.Drawing.Size(800, 600);
        
        // dodawanie paska menu
        this.Controls.Add(menu);
        menu.Dock = DockStyle.Top;
        ToolStripMenuItem pliki = new ToolStripMenuItem("Plik");
        menu.Items.Add(pliki);

        ToolStripMenuItem nowy = new ToolStripMenuItem();
        nowy.Text = "Nowy";
        nowy.Click += new EventHandler(nowy_klik);
        pliki.DropDownItems.Add(nowy);

        ToolStripMenuItem otworz = new ToolStripMenuItem();
        otworz.Text = "Otwórz";
        otworz.Click += new EventHandler(otworz_klik);
        pliki.DropDownItems.Add(otworz);
        
        ToolStripMenuItem zapisz = new ToolStripMenuItem();
        zapisz.Text = "Zapisz";
        zapisz.Click += new EventHandler(zapisz_klik);
        pliki.DropDownItems.Add(zapisz);

        this.Controls.Add(menu);
        menu.Dock = DockStyle.Top;
        ToolStripMenuItem edycja = new ToolStripMenuItem("Edycja");
        menu.Items.Add(edycja);

        ToolStripMenuItem font = new ToolStripMenuItem();
        font.Text = "Zmiana czcionki...";
        font.Click += new EventHandler(font_klik);
        edycja.DropDownItems.Add(font);

        // pole richtext na całe okienko
        this.Controls.Add(tekst);
        tekst.Dock = DockStyle.Fill;
        
        tekst.BringToFront();
    }

    private void nowy_klik(object sender, EventArgs e)
    {
        string message = "Czy jesteś pewien, że chcesz wyczyścić dokument?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = MessageBox.Show(message, Text, buttons);
        if (result == DialogResult.Yes)
        {
            tekst.Clear();
        }
        else {}
    }

    private void zamkniecie_formy(object sender, FormClosingEventArgs e)
    {
        string message = "Czy chcesz zamknąć aplikację?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = MessageBox.Show(message, Text, buttons);
        if (result == DialogResult.Yes)
        {
            this.Close();
        }
        else {}
    }

    private void otworz_klik(object sender, EventArgs e)
    {
        try
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Dokumenty tekstowe (.txt) | *.txt";
            dialog.Title = "Otwórz plik tekstowy";
            dialog.DefaultExt = ".txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                    tekst.LoadFile(dialog.FileName);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void zapisz_klik(object sender, EventArgs e)
    {
        SaveFileDialog dialog2 = new SaveFileDialog();
        dialog2.Filter = "Dokumenty tekstowe (.txt) | *.txt";
        dialog2.Title = "Zapisz plik tekstowy";
        dialog2.DefaultExt = ".txt";
        if (dialog2.ShowDialog() == DialogResult.OK)
        {
            tekst.SaveFile(dialog2.FileName);
        }
    }

    private void font_klik(object sender, EventArgs e)
    {
        FontDialog fontDialog1 = new FontDialog();
        fontDialog1.ShowColor = true;
        fontDialog1.Font = tekst.Font;
        fontDialog1.Color = tekst.ForeColor;

        if(fontDialog1.ShowDialog() != DialogResult.Cancel )
        {
            tekst.Font = fontDialog1.Font ;
            tekst.ForeColor = fontDialog1.Color;
        }
    }
}

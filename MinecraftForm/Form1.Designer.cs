
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftForm;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitolo = new Label();
        lblId = new Label();
        txtId = new TextBox();
        lblNome = new Label();
        txtNome = new TextBox();
        lblValore = new Label();
        txtValore = new TextBox();
        lblRarita = new Label();
        cmbRarita = new ComboBox();
        btnAggiungiStrumento = new Button();
        btnAggiungiBlocco = new Button();
        btnCraft = new Button();
        dataGridView1 = new DataGridView();

        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();

        // Titolo
        lblTitolo.Text = "MINECRAFT - INVENTARIO";
        lblTitolo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        lblTitolo.Location = new Point(25, 20);
        lblTitolo.AutoSize = true;

        // ID
        lblId.Text = "ID:";
        lblId.Location = new Point(25, 80);
        lblId.AutoSize = true;

        txtId.Location = new Point(120, 77);
        txtId.Size = new Size(200, 23);

        // Nome
        lblNome.Text = "Nome:";
        lblNome.Location = new Point(25, 120);
        lblNome.AutoSize = true;

        txtNome.Location = new Point(120, 117);
        txtNome.Size = new Size(200, 23);

        // Valore
        lblValore.Text = "Valore:";
        lblValore.Location = new Point(25, 160);
        lblValore.AutoSize = true;

        txtValore.Location = new Point(120, 157);
        txtValore.Size = new Size(200, 23);
        txtValore.Text = "10";

        // Rarità
        lblRarita.Text = "Rarità:";
        lblRarita.Location = new Point(25, 200);
        lblRarita.AutoSize = true;

        cmbRarita.Location = new Point(120, 197);
        cmbRarita.Size = new Size(200, 23);
        cmbRarita.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRarita.Items.AddRange(new object[]
        {
            "Common", "Rare", "Epic", "Legendary"
        });

        // Pulsante strumento
        btnAggiungiStrumento.Text = "Aggiungi strumento";
        btnAggiungiStrumento.Location = new Point(25, 260);
        btnAggiungiStrumento.Size = new Size(295, 35);
        btnAggiungiStrumento.Click += btnAggiungiStrumento_Click;

        // Pulsante blocco
        btnAggiungiBlocco.Text = "Aggiungi blocco";
        btnAggiungiBlocco.Location = new Point(25, 310);
        btnAggiungiBlocco.Size = new Size(295, 35);
        btnAggiungiBlocco.Click += btnAggiungiBlocco_Click;

        // Pulsante crafting
        btnCraft.Text = "Craft selezionato";
        btnCraft.Location = new Point(25, 370);
        btnCraft.Size = new Size(295, 35);
        btnCraft.Click += btnCraft_Click;

        // Tabella inventario
        dataGridView1.Location = new Point(350, 60);
        dataGridView1.Size = new Size(670, 450);
        dataGridView1.ReadOnly = true;
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.MultiSelect = false;
        dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.DisplayedCells;
        dataGridView1.RowHeadersVisible = false;

        dataGridView1.Columns.Add("Id", "ID");
        dataGridView1.Columns.Add("Nome", "Nome");
        dataGridView1.Columns.Add("Tipo", "Tipo");
        dataGridView1.Columns.Add("Valore", "Valore");
        dataGridView1.Columns.Add("Rarita", "Rarità");
        dataGridView1.Columns.Add("Dettagli", "Dettagli");

        dataGridView1.Columns["Dettagli"].AutoSizeMode =
            DataGridViewAutoSizeColumnMode.Fill;

        // Aggiunta controlli
        Controls.Add(lblTitolo);
        Controls.Add(lblId);
        Controls.Add(txtId);
        Controls.Add(lblNome);
        Controls.Add(txtNome);
        Controls.Add(lblValore);
        Controls.Add(txtValore);
        Controls.Add(lblRarita);
        Controls.Add(cmbRarita);
        Controls.Add(btnAggiungiStrumento);
        Controls.Add(btnAggiungiBlocco);
        Controls.Add(btnCraft);
        Controls.Add(dataGridView1);

        ClientSize = new Size(1050, 550);
        Text = "Minecraft Resource Manager";
        StartPosition = FormStartPosition.CenterScreen;

        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitolo;
    private Label lblId;
    private TextBox txtId;
    private Label lblNome;
    private TextBox txtNome;
    private Label lblValore;
    private TextBox txtValore;
    private Label lblRarita;
    private ComboBox cmbRarita;
    private Button btnAggiungiStrumento;
    private Button btnAggiungiBlocco;
    private Button btnCraft;
    private DataGridView dataGridView1;
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MinecraftForm;

public partial class Form1 : Form
{
    List<Item> inventario = new List<Item>();

    public Form1()
    {
        InitializeComponent();
        cmbRarita.SelectedIndex = 0;
    }

    private void btnAggiungiStrumento_Click(object sender, EventArgs e)
    {
        int valore;

        if (txtId.Text == "" || txtNome.Text == "" ||
            !int.TryParse(txtValore.Text, out valore))
        {
            MessageBox.Show("Inserisci tutti i dati correttamente.");
            return;
        }

        ItemRarity rarita = (ItemRarity)cmbRarita.SelectedIndex;

        ToolItem strumento = new ToolItem(
            txtId.Text, txtNome.Text, valore,
            rarita, 100, ToolType.Pickaxe
        );

        inventario.Add(strumento);
        AggiornaTabella();

        txtId.Clear();
        txtNome.Clear();
        txtValore.Clear();
    }

    private void btnAggiungiBlocco_Click(object sender, EventArgs e)
    {
        int valore;

        if (txtId.Text == "" || txtNome.Text == "" ||
            !int.TryParse(txtValore.Text, out valore))
        {
            MessageBox.Show("Inserisci tutti i dati correttamente.");
            return;
        }

        ItemRarity rarita = (ItemRarity)cmbRarita.SelectedIndex;

        BlockItem blocco = new BlockItem(
            txtId.Text, txtNome.Text, valore,
            rarita, true, 1
        );

        inventario.Add(blocco);
        AggiornaTabella();

        txtId.Clear();
        txtNome.Clear();
        txtValore.Clear();
    }

    private void AggiornaTabella()
    {
        dataGridView1.Rows.Clear();

        foreach (Item item in inventario)
        {
            string tipo = "Blocco";

            if (item is ToolItem)
            {
                tipo = "Strumento";
            }

            dataGridView1.Rows.Add(
                item.Id,
                item.Name,
                tipo,
                item.Value,
                item.Rarity,
                item.GetDetails()
            );
        }
    }

    private void btnCraft_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleziona un oggetto.");
            return;
        }

        int indice = dataGridView1.SelectedRows[0].Index;
        Item item = inventario[indice];

        if (item is ToolItem)
        {
            ToolItem strumento = (ToolItem)item;

            if (strumento.CanCraft())
            {
                strumento.Craft();
                MessageBox.Show("Craft eseguito!");
                AggiornaTabella();
            }
            else
            {
                MessageBox.Show("Durata insufficiente!");
            }
        }
        else
        {
            MessageBox.Show("Non puoi craftare un blocco!");
        }
    }
}

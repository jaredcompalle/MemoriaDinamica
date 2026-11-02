namespace MemoriaDinamica;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblEdad = new Label();
        nudEdad = new NumericUpDown();
        btnCrear = new Button();
        btnReferencia = new Button();
        btnStruct = new Button();
        lblNodos = new Label();
        nudNodos = new NumericUpDown();
        btnNodos = new Button();
        btnLiberar = new Button();
        lstObjetos = new ListBox();
        txtLog = new TextBox();
        lblEstado = new Label();
        btnLimpiar = new Button();
        ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudNodos).BeginInit();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(12, 16);
        lblNombre.Name = "lblNombre";
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(75, 12);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(140, 23);
        // 
        // lblEdad
        // 
        lblEdad.AutoSize = true;
        lblEdad.Location = new Point(230, 16);
        lblEdad.Name = "lblEdad";
        lblEdad.Text = "Edad:";
        // 
        // nudEdad
        // 
        nudEdad.Location = new Point(275, 12);
        nudEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
        nudEdad.Name = "nudEdad";
        nudEdad.Size = new Size(60, 23);
        nudEdad.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // btnCrear
        // 
        btnCrear.Location = new Point(350, 10);
        btnCrear.Name = "btnCrear";
        btnCrear.Size = new Size(190, 27);
        btnCrear.Text = "Crear objeto (new)";
        btnCrear.UseVisualStyleBackColor = true;
        btnCrear.Click += btnCrear_Click;
        // 
        // btnReferencia
        // 
        btnReferencia.Location = new Point(12, 48);
        btnReferencia.Name = "btnReferencia";
        btnReferencia.Size = new Size(200, 27);
        btnReferencia.Text = "Dos referencias, mismo objeto";
        btnReferencia.UseVisualStyleBackColor = true;
        btnReferencia.Click += btnReferencia_Click;
        // 
        // btnStruct
        // 
        btnStruct.Location = new Point(225, 48);
        btnStruct.Name = "btnStruct";
        btnStruct.Size = new Size(200, 27);
        btnStruct.Text = "Struct (valor) vs Class (ref)";
        btnStruct.UseVisualStyleBackColor = true;
        btnStruct.Click += btnStruct_Click;
        // 
        // lblNodos
        // 
        lblNodos.AutoSize = true;
        lblNodos.Location = new Point(12, 88);
        lblNodos.Name = "lblNodos";
        lblNodos.Text = "Nodos:";
        // 
        // nudNodos
        // 
        nudNodos.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        nudNodos.Location = new Point(75, 84);
        nudNodos.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudNodos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudNodos.Name = "nudNodos";
        nudNodos.Size = new Size(90, 23);
        nudNodos.Value = new decimal(new int[] { 100000, 0, 0, 0 });
        // 
        // btnNodos
        // 
        btnNodos.Location = new Point(180, 82);
        btnNodos.Name = "btnNodos";
        btnNodos.Size = new Size(200, 27);
        btnNodos.Text = "Crear lista enlazada";
        btnNodos.UseVisualStyleBackColor = true;
        btnNodos.Click += btnNodos_Click;
        // 
        // btnLiberar
        // 
        btnLiberar.Location = new Point(395, 82);
        btnLiberar.Name = "btnLiberar";
        btnLiberar.Size = new Size(200, 27);
        btnLiberar.Text = "Liberar memoria (GC)";
        btnLiberar.UseVisualStyleBackColor = true;
        btnLiberar.Click += btnLiberar_Click;
        // 
        // lstObjetos
        // 
        lstObjetos.FormattingEnabled = true;
        lstObjetos.ItemHeight = 15;
        lstObjetos.Location = new Point(12, 125);
        lstObjetos.Name = "lstObjetos";
        lstObjetos.Size = new Size(250, 334);
        // 
        // txtLog
        // 
        txtLog.Location = new Point(275, 125);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ReadOnly = true;
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(497, 334);
        // 
        // lblEstado
        // 
        lblEstado.AutoSize = true;
        lblEstado.Location = new Point(12, 475);
        lblEstado.Name = "lblEstado";
        lblEstado.Text = "Objetos Persona: 0";
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(672, 471);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(100, 27);
        btnLimpiar.Text = "Limpiar log";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 511);
        Controls.Add(btnLimpiar);
        Controls.Add(lblEstado);
        Controls.Add(txtLog);
        Controls.Add(lstObjetos);
        Controls.Add(btnLiberar);
        Controls.Add(btnNodos);
        Controls.Add(nudNodos);
        Controls.Add(lblNodos);
        Controls.Add(btnStruct);
        Controls.Add(btnReferencia);
        Controls.Add(btnCrear);
        Controls.Add(nudEdad);
        Controls.Add(lblEdad);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Programa 2 - Memoria dinámica (Heap, instancias y referencias)";
        ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudNodos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblEdad;
    private NumericUpDown nudEdad;
    private Button btnCrear;
    private Button btnReferencia;
    private Button btnStruct;
    private Label lblNodos;
    private NumericUpDown nudNodos;
    private Button btnNodos;
    private Button btnLiberar;
    private ListBox lstObjetos;
    private TextBox txtLog;
    private Label lblEstado;
    private Button btnLimpiar;
}

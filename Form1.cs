using System.Runtime.CompilerServices;

namespace MemoriaDinamica;

/// <summary>
/// Programa 2: Ejemplo de memoria dinámica (instancias, referencias a objetos en el Heap,
/// lista enlazada y liberación mediante el Garbage Collector).
/// </summary>
public partial class Form1 : Form
{
    private readonly List<Persona> personas = new();
    private Nodo cabeza = null;

    public Form1()
    {
        InitializeComponent();
    }

    // ---------- Utilidades ----------
    private void Log(string mensaje)
    {
        txtLog.AppendText(mensaje + Environment.NewLine);
    }

    // Identificador del objeto (sirve para comparar "direcciones" sin usar punteros inseguros)
    private static int Id(object o) => RuntimeHelpers.GetHashCode(o);

    private void ActualizarLista()
    {
        lstObjetos.Items.Clear();
        foreach (var p in personas)
            lstObjetos.Items.Add($"{p}  [id={Id(p)}]");

        lblEstado.Text = $"Objetos Persona: {personas.Count}  |  Memoria GC: {GC.GetTotalMemory(false) / 1024:N0} KB";
    }

    // ---------- 1) Crear instancias (new -> Heap) ----------
    private void btnCrear_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("Escribe un nombre.", "Aviso");
            return;
        }

        Persona p = new Persona { Nombre = txtNombre.Text.Trim(), Edad = (int)nudEdad.Value };
        personas.Add(p);

        Log($"[NEW] Persona \"{p}\" creada. El objeto está en el HEAP; la variable 'p' (referencia) está en el STACK. id={Id(p)}");
        ActualizarLista();
    }

    // ---------- 2) Dos referencias al MISMO objeto ----------
    private void btnReferencia_Click(object sender, EventArgs e)
    {
        if (personas.Count == 0)
        {
            MessageBox.Show("Crea al menos una persona.", "Aviso");
            return;
        }

        Persona original = personas[^1];
        Persona alias = original;                 // NO copia el objeto, solo la referencia

        alias.Nombre += " (modificado por alias)";

        Log("[REFERENCIA] alias = original;  alias.Nombre += ...");
        Log($"   original.Nombre = {original.Nombre}");
        Log($"   alias.Nombre    = {alias.Nombre}");
        Log($"   ¿Mismo objeto en Heap? {ReferenceEquals(original, alias)}  (id original={Id(original)}, id alias={Id(alias)})");
        ActualizarLista();
    }

    // ---------- 3) Struct (por valor) vs Class (por referencia) ----------
    private void btnStruct_Click(object sender, EventArgs e)
    {
        PuntoValor a = new PuntoValor { X = 1, Y = 2 };
        PuntoValor b = a;                         // COPIA completa del valor
        b.X = 99;

        Log("[STRUCT] b = a;  b.X = 99;");
        Log($"   a.X = {a.X}  (no cambió: son copias independientes)");
        Log($"   b.X = {b.X}");

        Persona p1 = new Persona { Nombre = "Ana", Edad = 20 };
        Persona p2 = p1;                          // misma referencia
        p2.Edad = 99;

        Log("[CLASS]  p2 = p1;  p2.Edad = 99;");
        Log($"   p1.Edad = {p1.Edad}  (cambió: ambos apuntan al mismo objeto)");
        Log("");
    }

    // ---------- 4) Lista enlazada dinámica ----------
    private void btnNodos_Click(object sender, EventArgs e)
    {
        int n = (int)nudNodos.Value;

        long antes = GC.GetTotalMemory(true);

        cabeza = null;
        Nodo actual = null;
        for (int i = 0; i < n; i++)
        {
            Nodo nuevo = new Nodo { Valor = i };  // cada nodo se reserva en el Heap
            if (cabeza == null)
            {
                cabeza = nuevo;
                actual = nuevo;
            }
            else
            {
                actual.Siguiente = nuevo;         // enlace (puntero/referencia) al siguiente
                actual = nuevo;
            }
        }

        long despues = GC.GetTotalMemory(false);

        Log($"[LISTA ENLAZADA] {n:N0} nodos creados dinámicamente.");
        Log($"   Memoria antes: {antes / 1024:N0} KB | después: {despues / 1024:N0} KB | diferencia: {(despues - antes) / 1024:N0} KB");
        ActualizarLista();
    }

    // ---------- 5) Liberar memoria (Garbage Collector) ----------
    private void btnLiberar_Click(object sender, EventArgs e)
    {
        WeakReference vigilante = new WeakReference(cabeza);   // no impide que el GC lo recoja
        long antes = GC.GetTotalMemory(false);

        personas.Clear();
        cabeza = null;                            // se pierden las referencias -> objetos "huérfanos"

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long despues = GC.GetTotalMemory(true);

        Log("[GC] Referencias eliminadas y recolector ejecutado.");
        Log($"   Memoria antes: {antes / 1024:N0} KB | después: {despues / 1024:N0} KB");
        Log($"   ¿La lista enlazada sigue viva en el Heap? {vigilante.IsAlive}");
        ActualizarLista();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtLog.Clear();
    }
}

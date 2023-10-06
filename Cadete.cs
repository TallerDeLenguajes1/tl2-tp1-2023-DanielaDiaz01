namespace EmpresaCadeteria;

public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private List<Pedido>? listaPedidos;

    public Cadete(int id, string nombre, string direccion, string telefono){
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.listaPedidos = new List<Pedido>();
        }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Pedido>? ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    //metodos
        public int CantidadPedidosEntregados(){
        int cantPedidosEntregados = 0;
        foreach(var p in listaPedidos){
            if(p.Estado == EstadoPedido.Entregado){ 
                cantPedidosEntregados++;
            }
        }
        return cantPedidosEntregados;
    }

    public double JornalACobrar(){
        return((double)500 * CantidadPedidosEntregados());
    }

    public void DarDeAltaPedido(int numero, string observacion, EstadoPedido estado, Cliente cliente)
    {
    // Crea un nuevo pedido
    Pedido nuevoPedido = new Pedido(numero, observacion, estado, cliente);

    // Agrega el pedido a la lista de pedidos del cadete
    this.listaPedidos.Add(nuevoPedido);
    }

}
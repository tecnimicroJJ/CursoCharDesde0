namespace TiendaDeGolosinasHerenciaPoli
{
    public abstract class Almacen
    {
        public abstract List<Producto> GetProductos(String producto);
        public abstract void addProducto(Producto producto);
    }
}
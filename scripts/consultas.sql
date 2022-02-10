  select sum(i.Cantidad) as cantidad, p.nombre,p.codigo,pro.nombre from Proveedor p
  inner join RemisionEntrada r on  p.Id=r.IdProveedor
  inner join Almacen a on a.Id=r.IdAlmacen
  inner join InventarioFisico i on i.IdAlmacen = a.Id
  inner join Producto pro on i.IdProducto = pro.Id
  group by p.nombre,p.codigo,pro.nombre;

  select pro.Codigo,pro.nombre,COUNT(*) as Total
  from  RemisionEntrada r 
  inner join Almacen a on a.Id=r.IdAlmacen
  inner join InventarioFisico i on i.IdAlmacen = a.Id
  inner join Producto pro on i.IdProducto = pro.Id
  and i.Cantidad>0
  group by pro.Codigo,pro.nombre;

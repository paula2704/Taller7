package org.eclipse.jakarta.hello;

import java.io.Serializable;

public class CartItem implements Serializable {

  private static final long serialVersionUID = 1L;

  private Product producto;
  private Integer cantidad;

  public CartItem() {}

  public CartItem(Product producto, Integer cantidad) {
    this.producto = producto;
    this.cantidad = cantidad;
  }

  public Double getSubtotal() {
    return producto.getPrecio() * cantidad;
  }

  public Product getProducto() {
    return producto;
  }

  public void setProducto(Product producto) {
    this.producto = producto;
  }

  public Integer getCantidad() {
    return cantidad;
  }

  public void setCantidad(Integer cantidad) {
    this.cantidad = cantidad;
  }
}

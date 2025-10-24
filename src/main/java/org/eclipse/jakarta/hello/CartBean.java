package org.eclipse.jakarta.hello;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;
import javax.enterprise.context.SessionScoped;
import javax.faces.application.FacesMessage;
import javax.faces.context.FacesContext;
import javax.inject.Named;

@Named("cartBean")
@SessionScoped
public class CartBean implements Serializable {

  private static final long serialVersionUID = 1L;

  private List<CartItem> items;

  public CartBean() {
    items = new ArrayList<>();
  }

  public void agregarAlCarrito(Product producto) {
    if (producto.getStock() > 0) {
      // Verificar si el producto ya está en el carrito
      for (CartItem item : items) {
        if (item.getProducto().getId().equals(producto.getId())) {
          if (item.getCantidad() < producto.getStock()) {
            item.setCantidad(item.getCantidad() + 1);
            addMessage(
              "Cantidad actualizada en el carrito",
              FacesMessage.SEVERITY_INFO
            );
            return;
          } else {
            addMessage(
              "No hay suficiente stock disponible",
              FacesMessage.SEVERITY_WARN
            );
            return;
          }
        }
      }
      // Si no está en el carrito, agregarlo
      items.add(new CartItem(producto, 1));
      addMessage("Producto agregado al carrito", FacesMessage.SEVERITY_INFO);
    } else {
      addMessage("Producto sin stock", FacesMessage.SEVERITY_ERROR);
    }
  }

  public void actualizarCantidad(CartItem item, int nuevaCantidad) {
    if (nuevaCantidad > 0 && nuevaCantidad <= item.getProducto().getStock()) {
      item.setCantidad(nuevaCantidad);
    } else if (nuevaCantidad > item.getProducto().getStock()) {
      addMessage(
        "La cantidad supera el stock disponible",
        FacesMessage.SEVERITY_WARN
      );
    } else if (nuevaCantidad <= 0) {
      eliminarDelCarrito(item);
    }
  }

  public void eliminarDelCarrito(CartItem item) {
    items.remove(item);
    addMessage("Producto eliminado del carrito", FacesMessage.SEVERITY_INFO);
  }

  public void vaciarCarrito() {
    items.clear();
    addMessage("Carrito vaciado", FacesMessage.SEVERITY_INFO);
  }

  public Double getTotal() {
    double total = 0.0;
    for (CartItem item : items) {
      total += item.getSubtotal();
    }
    return total;
  }

  public int getCantidadItems() {
    int cantidad = 0;
    for (CartItem item : items) {
      cantidad += item.getCantidad();
    }
    return cantidad;
  }

  private void addMessage(String summary, FacesMessage.Severity severity) {
    FacesMessage message = new FacesMessage(severity, summary, null);
    FacesContext.getCurrentInstance().addMessage(null, message);
  }

  // Getters y Setters
  public List<CartItem> getItems() {
    return items;
  }

  public void setItems(List<CartItem> items) {
    this.items = items;
  }
}

package org.eclipse.jakarta.hello;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;
import javax.annotation.PostConstruct;
import javax.faces.application.FacesMessage;
import javax.faces.context.FacesContext;
import javax.faces.view.ViewScoped;
import javax.inject.Named;

@Named("productBean")
@ViewScoped
public class ProductBean implements Serializable {

  private static final long serialVersionUID = 1L;

  private List<Product> productos;
  private Product nuevoProducto;
  private Product productoSeleccionado;
  private Long nextId = 1L;

  @PostConstruct
  public void init() {
    productos = new ArrayList<>();
    nuevoProducto = new Product();
    productoSeleccionado = new Product();

    // Productos de ejemplo
    productos.add(
      new Product(
        nextId++,
        "Laptop HP",
        "Laptop HP 16GB RAM, 512GB SSD",
        1200.00,
        10
      )
    );
    productos.add(
      new Product(
        nextId++,
        "Mouse Logitech",
        "Mouse inalámbrico Logitech MX Master",
        25.00,
        50
      )
    );
    productos.add(
      new Product(
        nextId++,
        "Teclado Mecánico",
        "Teclado mecánico RGB retroiluminado",
        80.00,
        30
      )
    );
    productos.add(
      new Product(
        nextId++,
        "Monitor Samsung",
        "Monitor Samsung 24 pulgadas Full HD",
        300.00,
        15
      )
    );
    productos.add(
      new Product(
        nextId++,
        "Webcam HD",
        "Webcam 1080p con micrófono integrado",
        45.00,
        25
      )
    );
  }

  public void agregarProducto() {
    if (
      nuevoProducto.getNombre() != null && !nuevoProducto.getNombre().isEmpty()
    ) {
      nuevoProducto.setId(nextId++);
      productos.add(nuevoProducto);
      nuevoProducto = new Product();
      addMessage("Producto agregado exitosamente", FacesMessage.SEVERITY_INFO);
    } else {
      addMessage(
        "Por favor complete todos los campos",
        FacesMessage.SEVERITY_ERROR
      );
    }
  }

  public void editarProducto(Product producto) {
    productoSeleccionado = producto;
  }

  public void actualizarProducto() {
    if (productoSeleccionado != null && productoSeleccionado.getId() != null) {
      for (int i = 0; i < productos.size(); i++) {
        if (productos.get(i).getId().equals(productoSeleccionado.getId())) {
          productos.set(i, productoSeleccionado);
          break;
        }
      }
      productoSeleccionado = new Product();
      addMessage(
        "Producto actualizado exitosamente",
        FacesMessage.SEVERITY_INFO
      );
    }
  }

  public void eliminarProducto(Product producto) {
    productos.remove(producto);
    addMessage("Producto eliminado exitosamente", FacesMessage.SEVERITY_INFO);
  }

  private void addMessage(String summary, FacesMessage.Severity severity) {
    FacesMessage message = new FacesMessage(severity, summary, null);
    FacesContext.getCurrentInstance().addMessage(null, message);
  }

  // Getters y Setters
  public List<Product> getProductos() {
    return productos;
  }

  public void setProductos(List<Product> productos) {
    this.productos = productos;
  }

  public Product getNuevoProducto() {
    return nuevoProducto;
  }

  public void setNuevoProducto(Product nuevoProducto) {
    this.nuevoProducto = nuevoProducto;
  }

  public Product getProductoSeleccionado() {
    return productoSeleccionado;
  }

  public void setProductoSeleccionado(Product productoSeleccionado) {
    this.productoSeleccionado = productoSeleccionado;
  }
}

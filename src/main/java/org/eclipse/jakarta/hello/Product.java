package org.eclipse.jakarta.hello;

import java.io.Serializable;

public class Product implements Serializable {

  private static final long serialVersionUID = 1L;

  private Long id;
  private String nombre;
  private String descripcion;
  private Double precio;
  private Integer stock;

  public Product() {}

  public Product(
    Long id,
    String nombre,
    String descripcion,
    Double precio,
    Integer stock
  ) {
    this.id = id;
    this.nombre = nombre;
    this.descripcion = descripcion;
    this.precio = precio;
    this.stock = stock;
  }

  // Getters y Setters
  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getNombre() {
    return nombre;
  }

  public void setNombre(String nombre) {
    this.nombre = nombre;
  }

  public String getDescripcion() {
    return descripcion;
  }

  public void setDescripcion(String descripcion) {
    this.descripcion = descripcion;
  }

  public Double getPrecio() {
    return precio;
  }

  public void setPrecio(Double precio) {
    this.precio = precio;
  }

  public Integer getStock() {
    return stock;
  }

  public void setStock(Integer stock) {
    this.stock = stock;
  }
}

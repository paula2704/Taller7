/* ============================================ */
/* ESTILOS GLOBALES */
/* ============================================ */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    min-height: 100vh;
    padding: 20px;
}

.container {
    max-width: 1400px;
    margin: 0 auto;
    background: white;
    border-radius: 15px;
    padding: 30px;
    box-shadow: 0 10px 40px rgba(0,0,0,0.2);
}

/* ============================================ */
/* HEADER Y NAVEGACIÓN */
/* ============================================ */
.header {
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    color: white;
    padding: 25px;
    border-radius: 10px;
    margin-bottom: 30px;
}

.header h1 {
    margin-bottom: 15px;
    font-size: 2.2em;
}

.nav {
    display: flex;
    gap: 15px;
    flex-wrap: wrap;
    align-items: center;
}

.nav-link {
    color: white;
    text-decoration: none;
    padding: 10px 20px;
    background: rgba(255,255,255,0.2);
    border-radius: 5px;
    transition: all 0.3s;
    font-weight: 500;
}

.nav-link:hover {
    background: rgba(255,255,255,0.3);
    transform: translateY(-2px);
}

.cart-link {
    background: #ff6b6b;
    font-weight: bold;
}

.cart-count {
    background: #51cf66;
    color: white;
    padding: 8px 15px;
    border-radius: 20px;
    font-weight: bold;
    font-size: 0.9em;
}

/* ============================================ */
/* MENSAJES */
/* ============================================ */
.messages {
    padding: 15px 20px;
    margin-bottom: 20px;
    border-radius: 8px;
    font-weight: 500;
}

.messages.info, .info {
    background: #d4edda;
    color: #155724;
    border: 1px solid #c3e6cb;
}

.messages.error, .error {
    background: #f8d7da;
    color: #721c24;
    border: 1px solid #f5c6cb;
}

.messages.warn, .warn {
    background: #fff3cd;
    color: #856404;
    border: 1px solid #ffeaa7;
}

.error-message {
    color: #dc3545;
    font-size: 0.85em;
    margin-top: 5px;
    display: block;
}

/* ============================================ */
/* GRID DE PRODUCTOS */
/* ============================================ */
.product-grid {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
    gap: 25px;
    margin-top: 20px;
}

.product-card {
    border: 2px solid #e0e0e0;
    border-radius: 12px;
    padding: 25px;
    transition: all 0.3s;
    background: white;
    display: flex;
    flex-direction: column;
}

.product-card:hover {
    transform: translateY(-5px);
    box-shadow: 0 8px 25px rgba(102, 126, 234, 0.3);
    border-color: #667eea;
}

.product-card h3 {
    color: #333;
    margin-bottom: 12px;
    font-size: 1.3em;
}

.descripcion {
    color: #666;
    font-size: 14px;
    margin-bottom: 15px;
    flex-grow: 1;
    line-height: 1.5;
}

.precio {
    font-size: 26px;
    font-weight: bold;
    color: #667eea;
    margin: 15px 0;
}

.stock {
    color: #666;
    font-size: 13px;
    margin-bottom: 15px;
    display: flex;
    align-items: center;
    gap: 10px;
}

.stock-badge {
    padding: 4px 10px;
    border-radius: 12px;
    font-size: 11px;
    font-weight: 600;
    text-transform: uppercase;
}

.stock-ok {
    background: #d4edda;
    color: #155724;
}

.stock-low {
    background: #fff3cd;
    color: #856404;
}

.stock-out {
    background: #f8d7da;
    color: #721c24;
}

/* ============================================ */
/* BOTONES */
/* ============================================ */
.btn {
    padding: 12px 24px;
    border: none;
    border-radius: 6px;
    cursor: pointer;
    font-size: 14px;
    transition: all 0.3s;
    font-weight: 600;
    text-decoration: none;
    display: inline-block;
    text-align: center;
}

.btn-primary {
    background: #667eea;
    color: white;
}

.btn-primary:hover:not(:disabled) {
    background: #5568d3;
    transform: translateY(-2px);
    box-shadow: 0 5px 15px rgba(102, 126, 234, 0.4);
}

.btn-secondary {
    background: #6c757d;
    color: white;
}

.btn-secondary:hover:not(:disabled) {
    background: #5a6268;
    transform: translateY(-2px);
}

.btn-danger {
    background: #ff6b6b;
    color: white;
}

.btn-danger:hover:not(:disabled) {
    background: #ff5252;
    transform: translateY(-2px);
}

.btn-success {
    background: #51cf66;
    color: white;
}

.btn-success:hover:not(:disabled) {
    background: #40c057;
    transform: translateY(-2px);
}

.btn-small {
    padding: 8px 16px;
    font-size: 14px;
    min-width: 80px;
}

.btn:disabled {
    background: #ccc;
    cursor: not-allowed;
    opacity: 0.6;
}

.btn-minus, .btn-plus {
    min-width: 35px;
    padding: 5px 10px;
    font-size: 16px;
    font-weight: bold;
}

.btn-delete {
    font-size: 13px;
}

/* ============================================ */
/* TABLAS */
/* ============================================ */
.cart-table, .product-table {
    width: 100%;
    border-collapse: collapse;
    margin: 20px 0;
    background: white;
    border-radius: 8px;
    overflow: hidden;
}

.cart-table th, .cart-table td,
.product-table th, .product-table td {
    padding: 15px;
    text-align: left;
    border-bottom: 1px solid #e0e0e0;
}

.cart-header, .table-header,
.cart-table th, .product-table th {
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    color: white;
    font-weight: 600;
    text-transform: uppercase;
    font-size: 0.9em;
    letter-spacing: 0.5px;
}

.cart-row-odd, .table-row-odd {
    background: #f8f9fa;
}

.cart-row-even, .table-row-even {
    background: white;
}

.cart-table tr:hover, .product-table tr:hover {
    background: #e3f2fd;
}

.table-responsive {
    overflow-x: auto;
}

.product-info {
    max-width: 300px;
}

.product-info strong {
    color: #333;
    font-size: 1.05em;
}

.product-info small {
    color: #666;
    line-height: 1.4;
}

.price {
    font-weight: bold;
    color: #667eea;
    font-size: 1.1em;
}

.subtotal {
    font-weight: bold;
    color: #51cf66;
    font-size: 1.15em;
}

.stock-info {
    display: block;
    color: #666;
    font-size: 0.85em;
    margin-top: 5px;
}

.stock-badge-table {
    padding: 4px 12px;
    border-radius: 12px;
    font-weight: 600;
    font-size: 0.95em;
}

/* ============================================ */
/* CONTROLES DE CANTIDAD */
/* ============================================ */
.quantity-control {
    display: flex;
    align-items: center;
    gap: 12px;
}

.quantity {
    font-weight: bold;
    min-width: 40px;
    text-align: center;
    font-size: 1.1em;
    color: #333;
}

/* ============================================ */
/* RESUMEN DEL CARRITO */
/* ============================================ */
.cart-summary {
    background: linear-gradient(135deg, #f8f9fa 0%, #e9ecef 100%);
    padding: 30px;
    border-radius: 12px;
    margin-top: 30px;
    border: 2px solid #667eea;
}

.cart-summary h3 {
    color: #333;
    margin-bottom: 20px;
    font-size: 1.5em;
}

.summary-line {
    display: flex;
    justify-content: space-between;
    padding: 12px 0;
    border-bottom: 1px solid #dee2e6;
    font-size: 1.05em;
}

.summary-value {
    font-weight: 600;
    color: #495057;
}

.total-line {
    border-bottom: none;
    border-top: 3px solid #667eea;
    margin-top: 15px;
    padding-top: 20px;
    font-size: 1.2em;
}

.summary-total {
    font-size: 1.8em;
    font-weight: bold;
    color: #667eea;
}

.cart-actions {
    display: flex;
    gap: 15px;
    margin-top: 25px;
    flex-wrap: wrap;
}

.cart-actions .btn {
    flex: 1;
    min-width: 150px;
}

/* ============================================ */
/* CARRITO VACÍO */
/* ============================================ */
.empty-cart {
    text-align: center;
    padding: 80px 20px;
}

.empty-icon {
    font-size: 5em;
    margin-bottom: 20px;
    opacity: 0.3;
}

.empty-cart h2 {
    color: #495057;
    margin-bottom: 15px;
}

.empty-cart p {
    font-size: 1.1em;
    color: #6c757d;
    margin-bottom: 30px;
}

/* ============================================ */
/* FORMULARIOS */
/* ============================================ */
.form-section {
    background: linear-gradient(135deg, #f8f9fa 0%, #e9ecef 100%);
    padding: 30px;
    border-radius: 12px;
    margin-bottom: 40px;
    border: 2px solid #667eea;
}

.form-section h2 {
    color: #333;
    margin-bottom: 25px;
    font-size: 1.5em;
}

.product-form {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 20px;
}

.form-group {
    display: flex;
    flex-direction: column;
}

.form-group label {
    font-weight: 600;
    color: #333;
    margin-bottom: 8px;
    font-size: 0.95em;
}

.form-group input,
.form-group textarea {
    padding: 12px;
    border: 2px solid #e0e0e0;
    border-radius: 6px;
    font-size: 14px;
    transition: all 0.3s;
    font-family: inherit;
}

.form-group input:focus,
.form-group textarea:focus {
    outline: none;
    border-color: #667eea;
    box-shadow: 0 0 0 3px rgba(102, 126, 234, 0.1);
}

.form-group textarea {
    resize: vertical;
    min-height: 80px;
}

.form-actions {
    grid-column: 1 / -1;
    margin-top: 10px;
}

.edit-input, .edit-textarea {
    width: 100%;
    padding: 8px 12px;
    border: 2px solid #667eea;
    border-radius: 5px;
    font-size: 14px;
}

.edit-textarea {
    resize: vertical;
}

.edit-price, .edit-stock {
    max-width: 120px;
}

.action-buttons {
    display: flex;
    gap: 8px;
    flex-wrap: wrap;
}

/* ============================================ */
/* TABLA DE GESTIÓN */
/* ============================================ */
.table-section {
    margin-top: 40px;
}

.table-section h2 {
    color: #333;
    margin-bottom: 20px;
    font-size: 1.5em;
}

/* ============================================ */
/* FOOTER */
/* ============================================ */
.footer {
    text-align: center;
    margin-top: 40px;
    padding-top: 20px;
    border-top: 2px solid #e0e0e0;
    color: #6c757d;
}

/* ============================================ */
/* TÍTULOS */
/* ============================================ */
h2 {
    color: #333;
    margin: 25px 0 15px 0;
    font-size: 1.8em;
}

/* ============================================ */
/* RESPONSIVE */
/* ============================================ */
@media (max-width: 1024px) {
    .product-grid {
        grid-template-columns: repeat(auto-fill, minmax(250px, 1fr));
    }
}

@media (max-width: 768px) {
    body {
        padding: 10px;
    }
    
    .container {
        padding: 20px;
    }
    
    .header h1 {
        font-size: 1.8em;
    }
    
    .product-grid {
        grid-template-columns: 1fr;
    }
    
    .product-form {
        grid-template-columns: 1fr;
    }
    
    .cart-actions {
        flex-direction: column;
    }
    
    .cart-actions .btn {
        width: 100%;
    }
    
    .nav {
        flex-direction: column;
        gap: 10px;
    }
    
    .nav-link {
        width: 100%;
        text-align: center;
    }
    
    .cart-table, .product-table {
        font-size: 12px;
    }
    
    .cart-table th, .cart-table td,
    .product-table th, .product-table td {
        padding: 10px 8px;
    }
    
    .summary-total {
        font-size: 1.5em;
    }
    
    .action-buttons {
        flex-direction: column;
    }
    
    .action-buttons .btn {
        width: 100%;
    }
}

@media (max-width: 480px) {
    .header h1 {
        font-size: 1.5em;
    }
    
    .product-card h3 {
        font-size: 1.1em;
    }
    
    .precio {
        font-size: 22px;
    }
    
    h2 {
        font-size: 1.5em;
    }
}
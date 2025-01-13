import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material/table';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { ProductService } from '../../../products/services/product.service';
import { Product, Category } from '../../../products/interfaces/product.interface';
import * as XLSX from 'xlsx';

@Component({
  selector: 'app-low-stock-report',
  standalone: true,
  imports: [
    CommonModule,
    MatTableModule,
    MatCardModule,
    MatButtonModule,
    MatIconModule
  ],
  templateUrl: './low-stock-report.component.html',
  styleUrls: ['./low-stock-report.component.scss']
})
export class LowStockReportComponent implements OnInit {
  products: Product[] = [];
  categories: Category[] = [];
  displayedColumns: string[] = ['name', 'description', 'price', 'stock', 'category'];
  LOW_STOCK_THRESHOLD = 5;

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.loadCategories();
    this.loadLowStockProducts();
  }

  loadCategories(): void {
    this.productService.getCategories().subscribe(categories => {
      this.categories = categories;
    });
  }

  loadLowStockProducts(): void {
    this.productService.getProducts().subscribe(products => {
      this.products = products.filter(p => p.stock < this.LOW_STOCK_THRESHOLD);
    });
  }

  exportToExcel(): void {
    const data = this.products.map(product => ({
      'Nombre': product.name,
      'Descripción': product.description,
      'Precio': product.price,
      'Stock': product.stock,
      'Categoría': this.getCategoryName(product.categoryId)
    }));

    const ws: XLSX.WorkSheet = XLSX.utils.json_to_sheet(data);
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Reporte de Stock Bajo');
    XLSX.writeFile(wb, 'reporte_stock_bajo.xlsx');
  }

  getCategoryName(categoryId: number): string {
    const category = this.categories.find(c => c.categoryId === categoryId);
    return category?.name || 'Sin categoría';
  }
} 
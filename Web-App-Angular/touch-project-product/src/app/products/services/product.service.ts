import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Product, Category } from '../interfaces/product.interface';
import mockProducts from '../data/mock-products.json';
import mockCategories from '../data/mock-categories.json';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private products: Product[] = mockProducts;
  private categories: Category[] = mockCategories;

  getProducts(): Observable<Product[]> {
    return of(this.products.filter(p => !p.isDeleted));
  }

  getCategories(): Observable<Category[]> {
    return of(this.categories);
  }

  getProduct(id: number): Observable<Product> {
    const product = this.products.find(p => p.productId === id && !p.isDeleted);
    return of(product!);
  }

  createProduct(product: Product): Observable<Product> {
    const newProduct = {
      ...product,
      productId: this.getNextId(),
      isDeleted: false
    };
    this.products.push(newProduct);
    return of(newProduct);
  }

  updateProduct(id: number, product: Product): Observable<Product> {
    const index = this.products.findIndex(p => p.productId === id);
    if (index !== -1) {
      this.products[index] = { ...product, productId: id };
      return of(this.products[index]);
    }
    throw new Error('Producto no encontrado');
  }

  deleteProduct(id: number): Observable<boolean> {
    const index = this.products.findIndex(p => p.productId === id);
    if (index !== -1) {
      this.products[index].isDeleted = true;
      return of(true);
    }
    return of(false);
  }

  private getNextId(): number {
    return Math.max(...this.products.map(p => p.productId ?? 0)) + 1;
  }
} 
export interface Product {
  productId?: number;
  name: string;
  description: string;
  price: number;
  stock: number;
  categoryId: number;
  category?: Category;
  isDeleted?: boolean;
}

export interface Category {
  categoryId: number;
  name: string;
  description?: string;
} 
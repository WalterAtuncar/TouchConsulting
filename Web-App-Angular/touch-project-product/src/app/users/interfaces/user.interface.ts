export interface User {
  id?: number;
  username: string;
  password?: string;
  roleId: number;
  personId: number;
  firstName: string;
  lastName: string;
  email: string;
  img?: string | null;
  isDeleted?: boolean;
}

export interface Role {
  id: number;
  name: string;
  description?: string;
}

export interface UserFormData {
  username: string;
  password?: string;
  roleId: number;
  firstName: string;
  lastName: string;
  email: string;
  img?: string | null;
} 
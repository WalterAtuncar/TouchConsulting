import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { User, Role, UserFormData } from '../interfaces/user.interface';
import mockUsers from '../data/mock-users.json';
import mockRoles from '../data/mock-roles.json';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private users: User[] = mockUsers.users;
  private roles: Role[] = mockRoles.roles;

  constructor() { }

  getUsers(): Observable<User[]> {
    return of(this.users.filter(user => !user.isDeleted));
  }

  getRoles(): Observable<Role[]> {
    return of(this.roles);
  }

  getUserById(id: number): Observable<User | undefined> {
    return of(this.users.find(user => user.id === id));
  }

  createUser(userData: UserFormData): Observable<User> {
    const newUser: User = {
      id: this.users.length + 1,
      personId: this.users.length + 1,
      ...userData,
      isDeleted: false
    };
    this.users.push(newUser);
    return of(newUser);
  }

  updateUser(id: number, userData: UserFormData): Observable<User | undefined> {
    const index = this.users.findIndex(user => user.id === id);
    if (index !== -1) {
      this.users[index] = { ...this.users[index], ...userData };
      return of(this.users[index]);
    }
    return of(undefined);
  }

  deleteUser(id: number): Observable<boolean> {
    const index = this.users.findIndex(user => user.id === id);
    if (index !== -1) {
      this.users[index].isDeleted = true;
      return of(true);
    }
    return of(false);
  }
}

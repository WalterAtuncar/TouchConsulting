import { Component, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatMenuModule
  ],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  @Output() toggleMenu = new EventEmitter<void>();

  constructor(private router: Router) {}

  logout(): void {
    // Limpiar el token y otros datos de autenticación
    localStorage.removeItem('token');
    // Navegar a la página de login
    this.router.navigate(['/login']);
  }
} 
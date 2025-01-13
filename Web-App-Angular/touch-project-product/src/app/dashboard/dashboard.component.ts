import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule, MatCardModule],
  template: `
    <div class="dashboard-container">
      <h1>Dashboard</h1>
      <p>¡Bienvenido al panel de control!</p>
      
      <div class="dashboard-cards">
        <mat-card>
          <mat-card-header>
            <mat-card-title>Estadísticas</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <p>Contenido del dashboard aquí</p>
          </mat-card-content>
        </mat-card>

        <mat-card>
          <mat-card-header>
            <mat-card-title>Actividad Reciente</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <p>Lista de actividades recientes aquí</p>
          </mat-card-content>
        </mat-card>
      </div>
    </div>
  `,
  styles: [`
    .dashboard-container {
      padding: 20px;
    }
    .dashboard-cards {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
      gap: 20px;
      margin-top: 20px;
    }
    mat-card {
      height: 100%;
    }
  `]
})
export class DashboardComponent {} 
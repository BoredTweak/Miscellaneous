import { HeaderComponent } from './@shared/header/header.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FooterComponent } from './@shared/footer/footer.component';
import { Routes, RouterModule } from '@angular/router';

const appRoutes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: DashboardComponent },
];

export const AppRouting = RouterModule.forRoot(appRoutes, { 
  useHash: true
});
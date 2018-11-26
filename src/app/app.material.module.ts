import { NgModule } from '@angular/core';
import { MatToolbarModule, MatCardModule, MatButtonModule, MatSidenavModule, MatIconModule, MatListModule, MatTableModule, MatGridListModule } from '@angular/material';
import { MatPaginatorModule, MatFormFieldModule, MatRadioModule, MatSelectModule, MatInputModule } from '@angular/material';
import { MatDatepickerModule, MatNativeDateModule, MatOptionModule, MatDialogModule } from '@angular/material';
import {  MatProgressSpinnerModule, MatSnackBarModule } from '@angular/material';
import { MatMenuModule} from '@angular/material/menu';

@NgModule({
    imports: [
        MatToolbarModule,
        MatCardModule,
        MatButtonModule,
        MatSidenavModule,
        MatIconModule,
        MatListModule,
        MatTableModule,
        MatGridListModule, 
        MatPaginatorModule,
        MatFormFieldModule,
        MatRadioModule,
        MatSelectModule,
        MatInputModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatOptionModule,
        MatDialogModule,
        MatProgressSpinnerModule,
        MatSnackBarModule,
        MatMenuModule
    ],
    exports: [
        MatToolbarModule,
        MatCardModule,
        MatButtonModule,
        MatSidenavModule,
        MatIconModule,
        MatListModule,
        MatTableModule,
        MatGridListModule, 
        MatPaginatorModule,
        MatFormFieldModule,
        MatRadioModule,
        MatSelectModule,
        MatInputModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatOptionModule,
        MatDialogModule,
        MatProgressSpinnerModule,
        MatSnackBarModule,
        MatMenuModule
    ],
})
export class AppMaterialModule { }

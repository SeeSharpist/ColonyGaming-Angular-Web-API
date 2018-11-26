import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ColonistsComponent } from './colonists.component';

describe('ColonistsComponent', () => {
  let component: ColonistsComponent;
  let fixture: ComponentFixture<ColonistsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ColonistsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ColonistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

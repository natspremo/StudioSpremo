import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TnavbarRegComponent } from './tnavbar-reg.component';

describe('TnavbarRegComponent', () => {
  let component: TnavbarRegComponent;
  let fixture: ComponentFixture<TnavbarRegComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TnavbarRegComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TnavbarRegComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

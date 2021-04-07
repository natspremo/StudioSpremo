import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomepageNonregComponent } from './homepage-nonreg.component';

describe('HomepageNonregComponent', () => {
  let component: HomepageNonregComponent;
  let fixture: ComponentFixture<HomepageNonregComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomepageNonregComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HomepageNonregComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

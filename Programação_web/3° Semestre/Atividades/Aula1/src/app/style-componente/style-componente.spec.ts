import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StyleComponente } from './style-componente';

describe('StyleComponente', () => {
  let component: StyleComponente;
  let fixture: ComponentFixture<StyleComponente>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StyleComponente]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StyleComponente);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

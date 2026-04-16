import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BootstrapComponente } from './bootstrap-componente';

describe('BootstrapComponente', () => {

  let component: BootstrapComponente;
  let fixture: ComponentFixture<BootstrapComponente>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BootstrapComponente]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BootstrapComponente);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
 }
);

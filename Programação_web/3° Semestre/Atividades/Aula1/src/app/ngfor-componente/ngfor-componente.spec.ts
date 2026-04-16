import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NgforComponente } from './ngfor-componente';

describe('NgforComponente', () => {
  let component: NgforComponente;
  let fixture: ComponentFixture<NgforComponente>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NgforComponente]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NgforComponente);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

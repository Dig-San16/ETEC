import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PipeProjeto } from './pipe-projeto';

describe('PipeProjeto', () => {
  let component: PipeProjeto;
  let fixture: ComponentFixture<PipeProjeto>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PipeProjeto],
    }).compileComponents();

    fixture = TestBed.createComponent(PipeProjeto);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

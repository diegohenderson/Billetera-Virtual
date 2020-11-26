import { TestBed } from '@angular/core/testing';

import { AltaclienteService } from './altacliente.service';

describe('AltaclienteService', () => {
  let service: AltaclienteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AltaclienteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

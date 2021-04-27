import { TestBed } from '@angular/core/testing';

import { RancherService } from './rancher.service';

describe('RancherService', () => {
  let service: RancherService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RancherService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

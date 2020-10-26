import { Component, OnInit } from '@angular/core';
import { PetFinderService } from 'src/app/pet-finder/pet-finder.service';
import { Observable } from 'rxjs';
import { PageEvent } from '@angular/material/paginator';

interface PetFinder {
  pet: Pet;
  pagination: Pagination;
}

interface Pet {
  id: bigint;
  organization_id: number;
  url: string;
  type: string;
  species: string;
  breeds: {
    primary: string;
    secondary: string;
    mixed: boolean;
    unknown: boolean;
  };
  colors: {
    primary: string;
    secondary: string;
    tertiary: string;
  };
  age: string;
  gender: string;
  size: string;
  coat: string;
  attributes: {
    spayed_neutered: boolean;
    house_trained: boolean;
    declawed: boolean;
    special_needs: boolean;
    shots_current: boolean;
  };
  tags: string[];
  name: string;
  description: string;
  photos: string[];
  videos: string[];
  status: string;
  published_at: Date;
  contact: {
    email: string;
    phone: string;
  };
  _links: {
    self: {
      href: string;
    }
    type: {
      href: string;
    }
    organization: {
      href: string;
    }
  };
}

interface Pagination {
  count_per_page: number;
  total_count: number;
  current_page: number;
  total_pages: number;
  _links: {
    previous: {
      href: string;
    }
    next: {
      href: string;
    }
  };
}


@Component({
  selector: 'app-pet-finder',
  templateUrl: './pet-finder.component.html',
  styleUrls: ['./pet-finder.component.css']
})
export class PetFinderComponent implements OnInit {
  pets: any = [];
  petFinder$: Observable<PetFinder[]>;
  pets$: Observable<Pet[]>;
  pagination$: Observable<Pagination>;
  // pageEvent: PageEvent;
  length: number;
  pageSize: number;

  pageEvent: PageEvent;

  // pageEvent(pageEvent: PageEvent) {
  //   console.log('pageEvent hit');
  //   console.log(pageEvent);
  // }

  constructor(private petFinderService: PetFinderService) { }

  ngOnInit() {
    this.petFinderService.getPets()
    .subscribe((data: any) => {
      this.petFinder$ = data;
      if (data.pagination != null) {
        this.pagination$ = data.pagination;
        console.log(`setting interfaces`);
        this.length = data.pagination.total_count;
        this.pageSize = data.pagination.count_per_page;
      }
      if (data.animals != null) {
        console.log(data);
        this.pets$ = data.animals;
      }
      console.log(this.petFinder$);
      console.log(this.pets$);
      console.log(this.pagination$);
    }
  );
  }

}




import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpHeaders, HttpClient , HttpErrorResponse} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PetFinderService {

  getPets(): Observable<any> {
    console.log('trying to get pets');
    return this.httpClient
      .get('/PetFinderController/GetPets');
  }

  constructor(private httpClient: HttpClient) { }
}

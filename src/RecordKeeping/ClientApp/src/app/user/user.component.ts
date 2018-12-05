import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html'
})
export class UserComponent {
  public users: User[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<User[]>(baseUrl + 'api/User/Users').subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }
}

interface User {
  userId: number;
  username: string;
  password: string;
  firstname: string;
  lastname: string;
  dateOfBirth: Date;
  email: string;
  phone: string;
  mobile: string;
}

import { BaseObject } from "./BaseObject";
import { Subject } from "./Subject";

export interface User extends BaseObject {
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  pseudo: string;
  subjects: Subject[];
}

export class User implements User {
  constructor() {
    this.firstName = "";
    this.lastName = "";
    this.email = "";
    this.password = "";
    this.pseudo = "";
    this.subjects = [];
  }
}

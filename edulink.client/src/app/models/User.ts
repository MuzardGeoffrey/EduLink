import { BaseObject } from "./BaseObject";
import { Subject } from "./Subject";

export class User extends BaseObject {
  firstName: string = "";
  lastName: string = "";
  email: string = "";
  password: string = "";
  pseudo: string = "";
  subjects: Subject[] = [];

  //constructor(firstName: string, lastName: string, email: string, pseudo: string, password?: string, id?: number, createdDate?: Date, lastUpdateDate?: Date) {
  //  super(id, createdDate, lastUpdateDate)
  //  this.firstName = firstName;
  //  this.lastName = lastName;
  //  this.email = email;
  //  this.password = password;
  //  this.pseudo = pseudo;
  //}

  get pseudoShortened(): string {
    return this.pseudo.slice(0, 3);
  }
}

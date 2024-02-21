import { Component, OnInit } from '@angular/core';
import { User, userRegistration } from '../../models/User';
import { HttpClientHelper } from '../../services/HttpClientHelper.service';
import { API_ROUTES } from '../../constants/api-routes';
import { AuthService } from '../../services/auth.service';
import { FormsModule } from '@angular/forms';
import { Subject, EnumSubject, enumLevelString } from '../../models/Subject';
import { KeyValuePipe } from '@angular/common';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css'],
  standalone: true,
  imports: [FormsModule, KeyValuePipe]
})
export class EditProfileComponent implements OnInit {
  userModel = new User;
  subjectModel = new Subject;
  confirmPassword = "";
  subjectList = new Array;
  enumSubjectKeys = Object.keys(EnumSubject);
  enumLevelString = enumLevelString;

  constructor(private http: HttpClientHelper, private Auth: AuthService) { }

  ngOnInit() {
    this.http.getAsync<User>(`${API_ROUTES.USER_DETAILS}${this.Auth.userId}`).subscribe((result: User) => {
      this.userModel = result;
      this.subjectList = this.userModel.subjects;
    });
  }

  onSubmit() {
    if (this.userModel.password == this.confirmPassword || this.userModel.password == "") {
      this.userModel.subjects = this.subjectList;
      this.http.putAsync<User>(`${API_ROUTES.USER_EDIT}${this.Auth.userId}`, this.userModel).subscribe((result: User) => {
        this.userModel = result;
        alert("Profile updated successfully");
      });
    }
  }

  addSubject(subject: Subject) {
    console.log("subject");
    console.log(subject);
    this.subjectList.push(subject);
  }

  removeSubject(id: number) {
    this.subjectList = this.subjectList.filter(d => !(d.id != id));
    console.log(this.subjectList);
    console.log("subjectList");
  }
}

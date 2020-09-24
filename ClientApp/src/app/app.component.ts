import { Component } from '@angular/core';
import { Repository } from './models/repository'
import { Question } from './models/question.model'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private repo: Repository){ }

  get question(): Question {
    return this.repo.question;
  }
}

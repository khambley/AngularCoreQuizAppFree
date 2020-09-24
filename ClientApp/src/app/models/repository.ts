import { Question } from "./question.model"
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class Repository {
    questionData: Question;

    constructor(private http: HttpClient){
        this.getQuestion(1);
    }

    getQuestion(id: number){
        this.http.get<Question>("/api/questions/" + id)
        .subscribe(q => {
            this.questionData = q;
            console.log("Question Data Received");
        });
    }
    get question(): Question {
        console.log("Question Data Requested");
        return this.questionData;
    }
}
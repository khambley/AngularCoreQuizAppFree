import { Question } from "./question.model"

export class Repository {
    constructor(){
        //this will be replaced with an HTTP web service later
        this.question = JSON.parse(document.getElementById("data").textContent);
    }
    question: Question;
}
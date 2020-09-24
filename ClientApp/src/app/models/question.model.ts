import { Quiz } from "./quiz.model";

export class Question {
    constructor(
        public questionId?: number,
        public text?: string,
        public correctAnswer?: string,
        public wrongAnswer1?: string,
        public wrongAnswer2?: string,
        public wrongAnswer3?: string,
        public quiz?: Quiz,
    ){}
}
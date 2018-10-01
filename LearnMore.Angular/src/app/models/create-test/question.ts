import { QuestionType } from './question-type';
import { Answer } from './answer';

export class Question {
    public contents: string;
    public type: QuestionType;
    public answers: Answer[];
    public correctAnswerId: number;
}

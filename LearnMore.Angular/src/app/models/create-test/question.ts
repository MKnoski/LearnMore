import { QuestionType } from './question-type';
import { Answer } from './answer';

export class Question {
    public title: string;
    public type: QuestionType;
    public answers: Answer[];
    public correctQuestionId: Answer[];
}

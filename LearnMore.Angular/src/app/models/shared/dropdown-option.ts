export class DropdownOption {
    public value: string;
    public isEnabled: boolean;

    constructor(value: string, isEnabled: boolean) {
        this.value = value;
        this.isEnabled = isEnabled;
    }
}

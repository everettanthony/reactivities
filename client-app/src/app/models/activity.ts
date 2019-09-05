export interface IActivity {
    id: string;
    title: string;
    description: string;
    category: string;
    date: Date;
    dateFormatted: Date;
    city: string; 
    state: string;
    zip: string;
    venue: string;
    isActive: boolean;
}
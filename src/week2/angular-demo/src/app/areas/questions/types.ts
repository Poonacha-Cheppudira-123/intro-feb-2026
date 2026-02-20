export type QuestionListItem = {
  id: string;
  title: string;
  content: string;
  submittedAnswers?: {
    id: string;
    content: string;
  }[];
};

/*    public record QuestionSubmissionItem
    {
        [MinLength(5), MaxLength(100)] public required string Title { get; set; } = string.Empty;
        [MinLength(10), MaxLength(1000)] public required string Content { get; set; } = string.Empty;
    }*/

export type QuestionSubmissionItem = {
  title: string;
  content: string;
};

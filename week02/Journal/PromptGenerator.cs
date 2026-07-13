public class PromptGenerator

{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What was the most challenging part of your day?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is one thing you could have done better today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

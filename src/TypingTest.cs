using System;

namespace typl.src;

public class TypingTest
{
    private readonly string testString;
    private int progress;
    private TypingTestState state;

    public TypingTest(string testString)
    {
        this.testString = testString;
        this.progress = 0;
        this.state = TypingTestState.Initiated;
    }

    public void Start()
    {
        if (this.state == TypingTestState.Initiated)
        {
            this.state = TypingTestState.Running;
        }
    }

    private void Finish()
    {
        if (this.state == TypingTestState.Running)
        {
            this.state = TypingTestState.Finished;
        }
    }

    public void ConsumeChar(Char c)
    {
        if (this.state != TypingTestState.Running)
        {
            return;
        }
        if (testString[progress] == c)
        {
            progress += 1;
            if (progress >= testString.Length)
            {
                this.Finish();
            }
        }
    }

    public string ToString(string progressmarker = "|")
    {
        return this.testString[..progress] + progressmarker + this.testString[progress..];
    }

}

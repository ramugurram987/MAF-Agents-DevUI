# Microsoft Agent Framework - Console Application

This is a sample .NET console application demonstrating the Microsoft Agent Framework with a basic AI agent implementation.

## Overview

This project sets up a functional AI agent using the Microsoft Agent Framework with the following features:

- **Sample AI Agent**: A basic implementation of an intelligent agent
- **Conversation History**: Tracks all interactions with the agent
- **Pattern-Based Responses**: Intelligent response generation based on user input
- **Async Processing**: Non-blocking agent operations
- **Interactive Console**: Real-time chat interface with the agent

## Project Structure

```
├── Program.cs                  # Main entry point and console loop
├── SampleAIAgent.cs           # Agent implementation and base class
├── MAF-ConsoleAgent.csproj    # Project configuration
└── README.md                  # Documentation
```

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 / VS Code (optional)

## Getting Started

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run
```

## Usage

Once running, the application will display an interactive console where you can:

1. Type messages and the AI agent will respond
2. Try common phrases like:
   - "hello" or "hi" - Get a greeting
   - "help" - Get help information
   - "who are you" - Learn about the agent
   - "what can you do" - Understand agent capabilities
   - "history" - Check conversation count
   - "exit" - Quit the application

## Example Interaction

```
=== Microsoft Agent Framework Console Application ===

Agent initialized: GreetingAgent

Enter your input (type 'exit' to quit):

You: hello
Agent: Hello! How can I assist you today?

You: what can you do
Agent: I can process your input, maintain conversation history, and provide intelligent responses based on patterns.

You: exit
Agent: Goodbye! Thank you for chatting.
```

## Features

### Agent Class Hierarchy

- **Agent** (Abstract Base Class)
  - Name: Agent identifier
  - Description: Agent description
  - ProcessAsync(): Abstract method for processing input

- **SampleAIAgent** (Implementation)
  - Pattern-based response generation
  - Conversation history management
  - Extensible design for custom responses

### Key Methods

- `ProcessAsync(string input)`: Main agent processing method
- `GetConversationHistory()`: Retrieve all conversation messages
- `ClearHistory()`: Reset conversation history
- `PrintHistory()`: Display conversation history to console

## Extending the Agent

To create a custom agent:

1. Inherit from the `Agent` abstract class
2. Implement the `ProcessAsync()` method
3. Add your own logic and response patterns

Example:

```csharp
public class CustomAgent : Agent
{
    public CustomAgent(string name) : base(name) { }

    public override async Task<string> ProcessAsync(string input)
    {
        // Your custom logic here
        return await Task.FromResult("Custom response");
    }
}
```

## Dependencies

- **Microsoft.SemanticKernel**: For advanced AI capabilities
- **Microsoft.Extensions.Configuration**: Configuration support
- **Microsoft.Extensions.DependencyInjection**: Dependency injection support
- **Microsoft.Extensions.Logging**: Logging capabilities

## License

This project is part of the MAF-Agents-DevUI repository.

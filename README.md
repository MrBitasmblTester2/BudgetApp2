# BudgetApp2 — title

A platform that helps users manage expenses, set savings goals, and receive AI-powered recommendations for smarter financial decisions.

## Tech Stack
- F# with ASP.NET Core
- FastAPI (Python)

## Requirements
- Transaction categorization system (support custom and auto-categorized transactions)
- Budget tracking with goal progress (recalculate after each transaction)
- AI-powered spending insights (start with static rules before integrating AI models)

## Installation
### Prerequisites
- .NET 6.0 SDK
- Python 3.8+

### .NET Backend Setup
bash
cd backend
dotnet restore
dotnet build

Set environment variables:
- ASPNETCORE_ENVIRONMENT=Development
- DATABASE_URL=your-database-connection-string

### FastAPI AI Service Setup
bash
cd ai-service
python -m venv venv
source venv/bin/activate  # Windows: venv\Scripts\activate
pip install -r requirements.txt

Set environment variables:
- AI_STATIC_RULES_CONFIG=path/to/config.json

## Usage
bash
# Run the ASP.NET Core service
cd backend
dotnet run

# Run the FastAPI AI service
cd ai-service
uvicorn main:app --reload

Access the services at:
- ASP.NET Core: http://localhost:5000
- FastAPI AI Service: http://localhost:8000

## Implementation Steps
1. Initialize an ASP.NET Core Web API project using F#.
2. Define domain models for Transaction, Category, Budget, and Goal.
3. Implement the transaction service with both custom and auto-categorization logic.
4. Build the budget tracking module to update goal progress after each transaction.
5. Scaffold a FastAPI service for AI-powered spending insights with static rule engine.
6. Define AI endpoints for spending insight recommendations in FastAPI.
7. Integrate the FastAPI AI service into the ASP.NET Core backend via HTTP client.
8. Configure environment-based settings for the database and AI service URLs.
9. Write unit tests for categorization and budget-tracking logic.
10. Document API contracts using OpenAPI/Swagger.

## API Endpoints
### ASP.NET Core Backend
- GET    /api/transactions
- POST   /api/transactions
- GET    /api/categories
- GET    /api/budgets
- POST   /api/budgets
- GET    /api/goals

### FastAPI AI Service
- POST   /insights/spending
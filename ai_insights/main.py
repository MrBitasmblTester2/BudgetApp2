# main.py
from fastapi import FastAPI
app = FastAPI()

@app.get("/insights")
def get_insights():
    # TODO: return static spending rules
    return {"insights": []}

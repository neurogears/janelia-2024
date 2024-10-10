import json
from pydantic import BaseModel, Field

class Trial(BaseModel):
    pos_x: float
    pos_y: float
    duration: float

class Block(BaseModel):
    trials: list[Trial]

if __name__ == "__main__":
    model_schema = Block.model_json_schema()
    with open("task.json", "w", encoding="utf-8") as f:
        f.write(json.dumps(model_schema, indent=2))
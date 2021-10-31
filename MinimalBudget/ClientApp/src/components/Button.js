import React from "react";
import Button from "@mui/material/Button";
export function Btn({ variant, style, buttonText, color }) {
  return (
    <div>
      <Button variant={variant} style={style} color={color}>
        {buttonText}
      </Button>
    </div>
  );
}

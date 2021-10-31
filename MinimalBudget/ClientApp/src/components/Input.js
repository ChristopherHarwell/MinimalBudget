import React from "react";
import { TextField } from "@mui/material";
// create a react functional component using material ui input
export const InputField = ({
  placeholder,
  inputProps,
  label,
  variant,
  color,
}) => {
  return (
    <div>
      <TextField
        placeholder={placeholder}
        inputProps={inputProps}
        label={label}
        variant={variant}
        color={color}
      />
    </div>
  );
};

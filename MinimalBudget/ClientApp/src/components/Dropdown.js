import React from "react";
import TextField from "@mui/material/TextField";
import Autocomplete from "@mui/material/Autocomplete";
export const Dropdown = ({ options, id, sx, label }) => {
  return (
    <div>
      <Autocomplete
        disablePortal
        id={id}
        options={options}
        sx={sx}
        renderInput={(params) => <TextField {...params} label={label} />}
      />
    </div>
  );
};

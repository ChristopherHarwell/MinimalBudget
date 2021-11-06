import React from "react";
import { InputField } from "@components/Input";
import { Dropdown } from "@components/Dropdown";
import Button from "@mui/material/Button";
import "./Styles.css";

// TODO: Replace this with actual data
import { dummyData } from "../data/dummyData";
import EnhancedTable from "../components/DataTable";
const temp = dummyData;

const inputFieldProps = {
  label: "Item Purchased",
  variant: "outlined",
  id: "outlined-basic",
};

const dropdownProps = {
  id: Math.random(),
  label: "Category",
  sx: { width: 300, height: "4.5rem" },
  options: dummyData,
};

export function AddItems() {
  const props = {
    addButton: {
      variant: "contained",
      style: {
        width: "5rem",
        height: "2.5rem",
        borderRadius: "5rem",
        fontSize: "2em",
        alignItems: "center",
      },
      color: "success",
    },
    deleteButton: {
      variant: "contained",
      style: {
        width: "5rem",
        height: "2.5rem",
        borderRadius: "5rem",
        fontSize: "1.5em",
        alignItems: "center",
      },
      color: "error",
    },
    tableData: {
      item: "Test",
      category: "Test",
    },
  };
  return (
    <div className="container">
      {/* Add Items */}
      <div className="add-items">
        {/* Input Fields */}
        <div className="input-fields">
          <InputField
            className="input-field"
            id={inputFieldProps.id}
            label={inputFieldProps.label}
            variant={inputFieldProps.variant}
          />
          <Dropdown
            id={dropdownProps.id}
            label={dropdownProps.label}
            sx={dropdownProps.sx}
            options={dropdownProps.options}
          />
          {/* Buttons */}
          <Button
            variant={props.addButton.variant}
            style={props.addButton.style}
            color={props.addButton.color}
          >
            +
          </Button>
          <Button
            variant={props.deleteButton.variant}
            style={props.deleteButton.style}
            color={props.deleteButton.color}
          >
            x
          </Button>
        </div>
      </div>
      {/* Data Table component */}
      <div className="table-container">
        <EnhancedTable />
      </div>
    </div>
  );
}

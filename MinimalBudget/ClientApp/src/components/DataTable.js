import React from "react";
import { Table, Thead, Tbody, Tr, Th, Td } from "react-super-responsive-table";
import "react-super-responsive-table/dist/SuperResponsiveTableStyle.css";

const props = {
  itemName: {
    label: "Item Name",
    data: "Dummy Item Name",
  },
  itemPrice: {
    label: "Item Price",
    data: "Dummy Item Price",
  },
  itemCategory: {
    label: "Item Category",
    data: "Dummy Item Category",
  },
  itemDescription: {
    label: "Item Description",
    data: "Dummy Item Description",
  },
  purchaseDate: {
    label: "Purchase Date",
    data: "Dummy Purchase Date",
  },
};

export default function EnhancedTable() {
  return (
    <Table>
      <Thead>
        <Tr>
          <Th>{props.itemName.label}</Th>
          <Th>{props.itemCategory.label}</Th>
          <Th>{props.itemDescription.label}</Th>
          <Th>{props.purchaseDate.label}</Th>
          <Th>{props.itemPrice.label}</Th>
        </Tr>
      </Thead>
      <Tbody>
        <Tr>
          <Td>{props.itemName.data}</Td>
          <Td>{props.itemCategory.data}</Td>
          <Td>{props.itemDescription.data}</Td>
          <Td>{props.purchaseDate.data}</Td>
          <Td>{props.itemPrice.data}</Td>
        </Tr>
        <Tr>
          <Td>{props.itemName.data}</Td>
          <Td>{props.itemCategory.data}</Td>
          <Td>{props.itemDescription.data}</Td>
          <Td>{props.purchaseDate.data}</Td>
          <Td>{props.itemPrice.data}</Td>
        </Tr>
        <Tr>
          <Td>{props.itemName.data}</Td>
          <Td>{props.itemCategory.data}</Td>
          <Td>{props.itemDescription.data}</Td>
          <Td>{props.purchaseDate.data}</Td>
          <Td>{props.itemPrice.data}</Td>
        </Tr>
      </Tbody>
    </Table>
  );
}

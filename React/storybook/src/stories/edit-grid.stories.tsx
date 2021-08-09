import React from 'react';
import { ComponentStory, ComponentMeta } from '@storybook/react';
import EditGrid from '../components/edit-grid';

export default {
  title: 'Example/EditGrid',
  component: EditGrid,
  argTypes: {
    backgroundColor: { control: 'color' },
  },
} as ComponentMeta<typeof EditGrid>;

const Template: ComponentStory<typeof EditGrid> = (args) => {
  return <EditGrid />;
};

export const Basic = Template.bind({});

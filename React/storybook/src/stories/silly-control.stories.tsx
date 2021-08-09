import React from 'react';
import { ComponentStory, ComponentMeta } from '@storybook/react';
import SillyControl from '../components/silly-control';

export default {
  title: 'Example/SillyControl',
  component: SillyControl,
  argTypes: {
    backgroundColor: { control: 'color' },
  },
} as ComponentMeta<typeof SillyControl>;

const Template: ComponentStory<typeof SillyControl> = (args) => {
  return <SillyControl {...args} />;
};

export const Invisible = Template.bind({});
Invisible.args = {
  visible: false,
  list: ['banana', 'cake', 'pop']
};

export const VisibleList = Template.bind({});
VisibleList.args = {
  visible: true,
  list: ['banana', 'cake', 'pop']
};

export const VisibleNoList = Template.bind({});
VisibleNoList.args = {
  visible: true
};


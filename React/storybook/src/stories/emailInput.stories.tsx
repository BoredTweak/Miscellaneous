import React from 'react';
import { ComponentStory, ComponentMeta } from '@storybook/react';
import EmailInput from '../components/emailInput';

export default {
  title: 'Example/EmailInput',
  component: EmailInput,
  argTypes: {
    backgroundColor: { control: 'color' },
  },
} as ComponentMeta<typeof EmailInput>;

const Template: ComponentStory<typeof EmailInput> = (args) => {
  return <EmailInput {...args} />;
};

export const Basic = Template.bind({});
Basic.args = {
  placeholder: 'EmailInput',
};
